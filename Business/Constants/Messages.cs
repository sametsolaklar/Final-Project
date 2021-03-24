using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string CategoryListed = "Kategoriler Listelendi.";
        public static string ProductCountOfCategoryError = "Belirtilen kategoride en fazla 10 adet ürün girilebilir.";
        public static string ProductNameAlreadyExists = "Ürün ismi kullanılıyor.";
        public static string CategoryLimitExceded = "En fazla 15 farklı kategori olabilir.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
