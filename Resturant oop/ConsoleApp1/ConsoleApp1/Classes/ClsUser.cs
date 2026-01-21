using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ResturantApp_oop.Classes;

public  abstract class ClsUser
{
    #region Properties
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public double Location { get; set; } 
    #endregion


    #region Methods
    public ClsUser()
    {
        this.UserId = 0;
        this.UserName = string.Empty;
        this.Email = string.Empty;
        this.Password = string.Empty;
        this.Phone = string.Empty;
        this.City = string.Empty;
        this.Location = 0.0;
    }
    public ClsUser(string userName, string password)
    {

    }
    public ClsUser(int userId, string userName, string email, string password, string phone, string city, double location)
    {
        UserId = userId;
        UserName = userName;
        Email = email;
        Password = password;
        Phone = phone;
        City = city;
        Location = location;
    }


    public bool  Login(string username, string password)
    {
        return true;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"UserName: {UserName}, Email: {Email}, Phone: {Phone}, City: {City}, Location: {Location}");
    }
    public abstract void ShowOrders();
    #endregion
}
