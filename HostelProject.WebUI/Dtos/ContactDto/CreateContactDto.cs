﻿namespace HostelProject.WebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
       
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subect { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
    }
}
