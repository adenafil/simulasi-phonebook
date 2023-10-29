using System;

namespace util
{
    public class Contact
    {
        private String noTelepon;
        private String nama;
        private String email;

        public Contact(String noTelepon, String nama, String email) {
            this.noTelepon = noTelepon;
            this.nama = nama;
            this.email = email;
        }

        public override String ToString() {
            return this.nama + " " + this.noTelepon + " " + this.email;
        }
    }
}