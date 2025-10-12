using System;


namespace WindowsFormsEntityFrameWorkCRUD
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
