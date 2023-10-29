using System;

namespace util
{
    public class Contact
    {
        private String noTelepon;

        private String nama;
        private String email;

        public String NoTelepon
        {
            get {return noTelepon;}
            set {if (value != null || value != "") noTelepon = value;}
        }

        public String Nama
        {
            get {return nama;}
            set {if (value != null || value != "") nama = value;}
        }

        public String Email
        {
            get {return email;}
            set {if (value != null || value != "") email = value;}
        }

        public Contact(String noTelepon, String nama, String email) {
            this.noTelepon = noTelepon;
            this.nama = nama;
            this.email = email;
        }

        public override String ToString() {
            return this.nama + " " + this.NoTelepon + " " + this.email;
        }
    }
}