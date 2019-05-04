using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;

        private MVCMusicStoreApplicationContext db = new MVCMusicStoreApplicationContext();

        public string CartId { get; private set; }

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            return cart;
        }
        private string GetCardId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";

            if (context.Session[CartSessionId] == null)
            {
                CartId = Guid.NewGuid().ToString();

                context.Session[CartSessionId] = CartId;
            }
            else
            {


                CartId = context.Session[CartSessionId].ToString();
            }
            return CartId;
        }
        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == this.ShoppingCartId).ToList();

        }
        public decimal GetCartTotal()
        {
            decimal? total = (from cartItem in db.Carts
                              where cartItem.CartId == this.ShoppingCartId
                              select cartItem.AlbumSelected.Price * (int?)cartItem.Count).Sum();

            return total ?? decimal.Zero;
        }
        public void AddToCart(int albumid)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.AlbumId == albumid);

            if (cartItem == null)
            {
                cartItem = new Cart()
                {
                    CartId = this.ShoppingCartId,
                    AlbumId = albumid,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Count = cartItem.Count++;
            }
            db.SaveChanges();
        }
        public int RemoveFromCart(int recordId)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.RecordId == recordId);
            if (cartItem == null)
            {
                throw new NullReferenceException();
        }
            int newCount;
            
            if (cartItem.Count > 1)
            {
                cartItem.Count--;
                newCount = cartItem.Count;
            }
            else
            {
                db.Carts.Remove(cartItem);
                newCount = 0;
            }
            db.SaveChanges();

            return newCount;
        }
    }
    }
