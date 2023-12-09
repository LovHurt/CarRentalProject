using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameOrPriceInvalid = "Car Description or Daily Price is invalid";
        public static string CarAdded = "Car added";
        public static string CarDeleted = "Car deleted";
        public static string CarUpdated = "Car updated";
        public static string CarListed = "Cars listed";
        public static string ColorAdded = "Color added";
        public static string ColorDeleted = "Color deleted";
        public static string ColorUpdated = "Color updated";
        public static string BrandUpdated = "Brand updated";
        public static string BrandAdded = "Brand added";
        public static string BrandDeleted = "Brand deleted";
        public static string RentalInvalid = "Sorry, you can not rent this car at the moment";
        public static string RentalAdded = "You have rented the car, please enjoy it!";
        public static string UserAdded = "User added";
        public static string UserDeleted = "User deleted";
        public static string UserNotFound = "User not found";



        ////CAR MESSAGE
        //public static string CarAdded = "Araba eklendi";
        //public static string CarUpdated = "Araba güncellendi";
        //public static string CarDeleted = "Araba silindi";
        //public static string CarNameInvalid = "Araba ismi geçersiz";
        //public static string MaintenanceTime = "Sistem bakımda";
        //public static string CarsListed = "Arabalar listelendi";

        ////USER MESSAGE
        public static string UsersAddedSuccessMessage = "Kullanıcı eklendi";

        public static string AuthorizationDenied = "Authorization denied";

        public static string AccessTokenCreated = "Access Token Created";

        public static string SuccessfulLogin = "Successful Login";

        public static string PasswordError = "Password incorrect";

        public static string UserRegistered = "User successfully registered";

        public static string UserAlreadyExists = "User already exists";
        //public static string UsersAddedErrorMessage = "Kullanıcı eklenirken hata oluştu";
        //public static string UsersDeletedSuccessMessage = "Kullanıcı silindi";
        //public static string UsersDeletedErrorMessage = "Kullanıcı silinirken hata oluştu";
        //public static string UsersListedSuccessMessage = "Kullanıcılar listelendi";
        //public static string UsersListedErrorMessage = "Kullanıcı bulunamadı";
        //public static string UsersUpdatedSuccessMessage = "Kullanıcı güncellendi";
        //public static string UsersUpdatedErrorMessage = "Kullanıcı güncellenirken hata oluştu";
        //public static string UsersExistErrorMessage = "Kullanıcı mevcut";

        ////CUSTOMER MESSAGE
        //public static string AddedCustomer = "Müşteri eklendi";
        //public static string DeletedCustomer = "Müşteri silindi";
        //public static string ListedCustomers = "Müşteriler listelendi";
        //public static string UpdatedCustomer = "Müşteri güncellendi";

        ////RENTAL MESSAGE
        //public static string RentalAdded = "Kiralama eklendi";
        //public static string RentalDeleted = "Kiralama silindi";
        //public static string RentalUpdated = "Kiralama güncellendi";
        //public static string RentalsListed = "Kiralamalar listelendi";
        //public static string RentalListed = "Kiralama listelendi";
        //public static string RentalCarError = "Araç kiralanamaz";

        ////BRAND MESSAGE
        //public static string BrandAdded = "Marka eklendi";
        //public static string BrandDeleted = "Marka silindi";
        //public static string BrandUpdated = "Marka güncellendi";
        //public static string BrandNameInvalid = "Marka ismi geçersiz";
        //public static string BrandsListed = "Markalar listelendi";
        //public static string BrandListed = "Marka listelendi";

        ////COLOR MESSAGE
        //public static string ColorAdded = "Renk eklendi";
        //public static string ColorDeleted = "Renk silindi";
        //public static string ColorUpdated = "Renk güncellendi";
        //public static string ColorListed = "Renkler listelendi";
    }
}
