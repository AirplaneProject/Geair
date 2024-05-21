﻿namespace Geair.WebUI.Areas.Admin.Dtos.BlogDtos
{
    public class ResultBlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }
    }
}