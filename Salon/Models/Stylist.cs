using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace BestRestaurant.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public string Availability { get; set; }
    public virtual ICollection<Client> Clients { get; set; } 
  }  
}