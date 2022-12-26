using Microsoft.AspNet.Identity.EntityFramework;

namespace Models;

public class Customer : IdentityUser
{
    public PaymentConfig PaymentConfig {get; set;}
}