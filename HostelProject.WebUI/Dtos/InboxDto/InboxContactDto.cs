﻿namespace HostelProject.WebUI.Dtos.InboxDto
{
    public class InboxContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subect { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
