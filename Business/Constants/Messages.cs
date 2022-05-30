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
        public static string Added="1";
        public static string b="1";
        public static string c="1";
        public static string AuthorizationDenied="Yetki Yok";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string UserRegistered="userRegistered";
        public static string PasswordError= "PasswordError";
        public static string SuccessfulLogin= "SuccessfulLogin";
        public static string UserAlreadyExists= "UserAlreadyExists";
        public static string AccessTokenCreated= "AccessTokenCreated";
    }
}
