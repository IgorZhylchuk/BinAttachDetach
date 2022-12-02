using BarcodeLib;
using BinAttachment.Models;
using BinAttachmentApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks; 

namespace BinAttachment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext dBContext;
        private readonly SignInManager<UsersIdentity> _signInManager;
        private readonly UserManager<UsersIdentity> _userManager;
   



        public HomeController(ApplicationDBContext context, SignInManager<UsersIdentity> signInManager, UserManager<UsersIdentity> userManager)
        {
            _userManager = userManager;
            dBContext = context;
            _signInManager = signInManager;
 
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel login = new LoginViewModel();
            var user = _userManager.FindByEmailAsync(login.Email);
            ViewBag.User = user;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    if (user != null)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {
                            if (_userManager.GetRolesAsync(user).Result.FirstOrDefault() == "Doctor")
                            {
                                return RedirectToAction("DayWorkingList", "Doctors");
                            }
                            else
                            {
                                return RedirectToAction("TimeSlot", "Home");
                            }
                        }
                    }

                    ViewBag.Result = "Error";
                    ModelState.AddModelError("", "User was not found. Chek your email or password!");
                    return View();


                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
            return View();
        }

        public IActionResult AttachDetach()
        {
            MainBinAttachment binAttachment = new MainBinAttachment();
            ViewBag.Processes = new SelectList(binAttachment.Processes, "Id", "Name");
            return View();
        }
        public JsonResult CheckAttaching(string process, string machine)
        {
            string bin = "";
            try
            {
                var machineName = dBContext.Machines.Where(m => m.ProcessModelId == Int32.Parse(process)).Where(m => m.Id == Int32.Parse(machine)).Select(m => m).FirstOrDefault();
                bin = dBContext.Bins.Where(p => p.ProcessId == Int32.Parse(process) && p.Machine == machineName).Select(b => b.BinNumber).FirstOrDefault();
                
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            if(bin == "")
            {
                return Json(null);
            }
            return Json(new { binNumber = bin });
        }

        [HttpPost]
        public async Task<IActionResult> AttachDetach(AttachedStringNamesModel model)
        {
            BinAttachmentModel bin = new BinAttachmentModel();
            bin.Id = dBContext.Bins.Where(n => n.BinNumber == model.BinNumber).Select(i => i.Id).Single();
            bin.MachineName = dBContext.Machines.Where(i => i.Id == Int32.Parse(model.MachineName)).Select(n => n.Name).Single();
            bin.Machine = dBContext.Machines.Where(m => m.ProcessModelId == Int32.Parse(model.ProcessName)).Where(m => m.Id == Int32.Parse(model.MachineName)).Select(m => m).Single();
            bin.ProcessId = Int32.Parse(model.ProcessName);
            bin.ProcessName = dBContext.Processes.Where(i => i.Id == Int32.Parse(model.ProcessName)).Select(n => n.Name).Single();
            bin.BinNumber = model.BinNumber;
            bin.BinStatus = "Filling";

            dBContext.Bins.Update(bin);
            await dBContext.SaveChangesAsync();
           
            return RedirectToAction("Index", "Home");

        }


        public IActionResult BinAttachment()
        {
            MainBinAttachment binAttachment = new MainBinAttachment();
            ViewBag.Processes = new SelectList(binAttachment.Processes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BinAttachment(AttachedStringNamesModel model)
        {
                BinAttachmentModel bin = DefaultUsers.Attach(dBContext, model);
                dBContext.Bins.Update(bin);
                await dBContext.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

        }
        public JsonResult BinStatus(string binNumber)
        {
            var bin = dBContext.Bins.Where(n => n.BinNumber == binNumber).Select(b => b);
            var status = bin.Select(s => s.BinStatus).SingleOrDefault();
            var process = bin.Select(p => p.ProcessName).SingleOrDefault();
            var machine = bin.Select(m => m.MachineName).SingleOrDefault();

            return Json(new { status, process, machine });
 
        }
        public JsonResult BinStatusForDetaching(int id)
        {
            var bin = dBContext.Bins.Where(n => n.Id == id).Select(b => b);
            var status = bin.Select(s => s.BinStatus).SingleOrDefault();
            var process = bin.Select(p => p.ProcessName).SingleOrDefault();
            var machine = bin.Select(m => m.MachineName).SingleOrDefault();

            return Json(new { status, process, machine });

        }

        public JsonResult Machines(int ProcessModelId)
        {
            MainBinAttachment binAttachment = new MainBinAttachment();
            var result = binAttachment.Machines.Where(p => p.ProcessModelId == ProcessModelId);
            return Json(new SelectList(result, "Id", "Name"));
        }
        [HttpPost]

        public IActionResult MainPage()
        {
            return View();
        }
        public IActionResult AttachDetachMenu()
        {
            IEnumerable<MachineModel> machines = dBContext.Machines.Select(m => m).ToArray();
            IEnumerable<ProcessModel> processes = dBContext.Processes.Select(n => n).ToList();
            var bins = dBContext.Bins.Where(s => s.BinStatus == "Filling").Select(b => b).ToList();
           
     

            ViewBag.Processes = processes;
            ViewBag.Machines = machines;
            ViewBag.Bins = bins;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AttachDetachMenu(AttachedStringNamesModel model)
        {
            BinAttachmentModel bin = DefaultUsers.Attach(dBContext, model);
            dBContext.Bins.Update(bin);
            await dBContext.SaveChangesAsync();
            return RedirectToAction("AttachDetachMenu", "Home");
        }
        public JsonResult GetBin(int id)
        {
            var binNumber = dBContext.Bins.Where(i => i.Machine.Id == id).Select( n => n.BinNumber).ToList();

            return Json(binNumber);
        }
        public JsonResult GetBins()
        {
            
            IEnumerable<BinAttachmentModel> list = dBContext.Bins.Select(b => b).ToList();
           return Json(list);
        }
        public JsonResult BinsChecking(string number)
        {
            var containing = dBContext.Bins.Select(n => n.BinNumber).Contains(number);
            if(number.Length == 12 && containing == false)
            {
                return Json(false);
            }
            
            return Json(true);
        }
        public IActionResult Details(int id)
        {
            var bin = dBContext.Bins.Where(i => i.Id == id).Select(b => b).FirstOrDefault();
            ViewBag.Number = bin;
            return View(bin);
        }

        [HttpGet]
        public IActionResult BinAdding()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BinAdding(BinAttachmentModel bin)
        {
            if(bin != null)
            {
                BinAttachmentModel binAdded = new BinAttachmentModel();
                binAdded.Id = bin.Id;
                binAdded.BinNumber = bin.BinNumber;
                binAdded.BinStatus = "Free to use";
                await dBContext.AddAsync(binAdded);
                dBContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
            
        }
        public async Task<IActionResult> Detach(string binNumber)
        {
            BinAttachmentModel bin = DefaultUsers.Detach(dBContext, binNumber);
  
            dBContext.Bins.Update(bin);
            await dBContext.SaveChangesAsync();
            
            return Json(new { success = true, message = "Detached successfully" });
        }
        [HttpPost]
        public async Task<IActionResult> BinDetaching(string binNumber)
        {
            BinAttachmentModel bin = DefaultUsers.Detach(dBContext, binNumber);
            dBContext.Bins.Update(bin);
            await dBContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var result = dBContext.Bins.Where(b => b.Id == id).FirstOrDefault();
            dBContext.Bins.Remove(result);
            await dBContext.SaveChangesAsync();
            return Json(new { success = true, message = "Removed successfully" });
        }

        public IActionResult GenerateBarCode()
        {
            return View();
        }

        public JsonResult GenerateCodeById(int id)
        {
            var bin = dBContext.Bins.Where(i => i.Id == id).Select(b => b.BinNumber);
            return Json(bin);
        }

        [HttpPost]
        public IActionResult GenerateBarCode(BinAttachmentModel bin)
        {
            if (bin != null)
            {
                return RedirectToAction("GenerateBarCodeMain", new { code = bin.BinNumber});
            }
            return View();
        }
        public IActionResult GenerateBarCodeMain(string code)
        {
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;
            barcode.LabelPosition = LabelPositions.BOTTOMCENTER;
            barcode.AlternateLabel = code;
            barcode.LabelFont = new Font(System.Drawing.FontFamily.GenericSansSerif, 18, FontStyle.Bold, GraphicsUnit.Pixel);
            Image image = barcode.Encode(BarcodeLib.TYPE.CODE39Extended, code, Color.Black, Color.White, 400, 200);

            var data = ConvertImageToBytes(image);

            return File(data, "image/jpeg");
        }

        private byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
