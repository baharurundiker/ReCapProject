using Core.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ekleme başarılı!";
        public static string ProductNameInvalid = "İsim geçersiz!";
        public static string MaintenanceTime = "Bakımda...";
        public static string ProductListed = "Sıralama Başarılı!";
        public static string ProductDeleted = "Silme Başarılı!";
        public static string ProductUpdated = "Güncelleme Başarılı!";
        public static string ReturnError = "Araba daha teslim olmamıştır!";
        public static string CarImageLimitExceeded ="Fotoğraf sınırı aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserNotFound;
        public static string UserRegistered;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
        public static string CarImageCouldNotBeAdded;
    }
}
