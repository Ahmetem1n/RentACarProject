using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded="Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string Deleted="Silme işlemi yapıldı.";
        public static string Updated="Güncelleme işlemi yapıldı.";
        public static string Listed="Listeleme işlemi yapıldı.";
        public static string Get="Detay getirme işlemi yapıldı.";
        public static string ErrorAdded = "Ekleme işlemi yapılamadı.";
        public static string ErrorDeleted = "Silme işlemi yapılamadı.";
        public static string ErrorUpdated = "Güncelleme işlemi yapılamadı.";
        public static string ErrorListed = "Listeleme işlemi yapılamadı.";
        public static string ErrorGet = "Detay getirme işlemi yapılamadı.";
        public static string Added="";
        public static string b;
        public static string c;
        public static string AuthorizationDenied;
        internal static User UserNotFound;
        internal static string UserRegistered;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
