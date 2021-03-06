﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
            db.Carts.Add(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();

            Cart p = db.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;

            db.SaveChanges();

            return cart.DatePurchased + " was succesfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }
    public string DeleteCart(int id)
    {
        try
        {
            CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }
}