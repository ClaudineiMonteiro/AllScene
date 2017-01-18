using System;
using System.Collections.Generic;
using System.Web.Http;
using AllScene.Application.Interfaces;
using AllScene.Application.ViewModels;
using DomainValidation.Validation;

namespace AllScene.Services.REST.ClienteAPI.Controllers
{
	[Route("api/[controller]")]
	public class SegmentController : ApiController
    {
		#region Attributes
		private readonly ISegmentAppService _segmentAppService;
		#endregion

		#region Constructors

	    public SegmentController(ISegmentAppService segmentAppService)
	    {
		    _segmentAppService = segmentAppService;
	    }
		#endregion

		#region Methods
		// GET: api/Segment
		[HttpGet]
		public IEnumerable<SegmentViewModel> GetAll()
		{
			return _segmentAppService.GetAll();
		}

        // GET: api/Segment/5
		public SegmentViewModel GetById(Guid id)
		{
			return _segmentAppService.GetById(id);
		}

        // POST: api/Segment
		[HttpPost]
        public SegmentViewModel Post([FromBody]SegmentViewModel segmentViewModel)
		{
			if (ModelState.IsValid)
			{
				segmentViewModel = _segmentAppService.Add(segmentViewModel);

				if (!segmentViewModel.ValidationResult.IsValid)
				{
					foreach (var erro in segmentViewModel.ValidationResult.Erros)
					{
						ModelState.AddModelError(string.Empty, erro.Message);
					}
				}


				if (!segmentViewModel.ValidationResult.Message.IsNullOrWhiteSpace())
				{
					ViewBag.Sucesso = clienteEnderecoViewModel.ValidationResult.Message;
					return View(clienteEnderecoViewModel);
				}

				return RedirectToAction("Index");
			}

			return View(clienteEnderecoViewModel);
		}

        // PUT: api/Segment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Segment/5
        public void Delete(int id)
        {
        }
		#endregion
	}
}
