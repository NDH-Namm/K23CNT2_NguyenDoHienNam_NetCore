using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace NdhnLesson04.Models
{
    public class NdhnBook
    {
        public string NdhnId { get; set; }    
        public string NdhnTitle { get; set; }
        public string NdhnDescription { get; set; }
        public string NdhnImage {  get; set; }
        public float NdhnPrice { get; set; }
        public int NdhnPage { get; set; }
    }
}
