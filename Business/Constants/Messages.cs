using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime= "Sistem bakımda...";

        public static string CarAdded = "Araç eklendi.";
        public static string CarDescriptionInvalid = "Açıklama bilgisi en az 2 karekter olmalıdır.";
        public static string CarListed = "Araçlar listelendi.";
        public static string CarUpdated = "Araç bilgisi güncellendi.";
        public static string CarDeleted = "Araç silindi. ";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandNameInvalid = "Marka ismi en az 2 karekter olmalıdır.";
        public static string BrandListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka bilgisi güncellendi.";
        public static string BrandDeleted = "Marka silindi. ";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorNameInvalid = "Renk ismi en az 2 karekter olmalıdır.";
        public static string ColorListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk bilgisi güncellendi.";
        public static string ColorDeleted = "Marka silindi. ";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserFirstNameInvalid = "Kullanıcı ismi en az 2 karekter olmalıdır.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı bilgisi güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi. ";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerNotAdded = "Müşteri eklenemedi.Şirket ismi en az 2 karakter olmalıdır.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CustomerUpdated = "Müşter bilgisi güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi. ";

        internal static string RentalDeleted ="Kiralama işlemi silindi";
        internal static string RentalListed="Kiralama işlemleri listelendi";
        internal static string RentalUpdated="Kiralama işlemi güncellendi";
        internal static string RentalAdded="Kiralama işlemi eklendi";
        internal static string RentalNotAdded="Kiralama işlemi geçersiz.";
    }
}
