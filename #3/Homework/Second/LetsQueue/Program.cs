using System;
using System.Collections.Generic;

namespace LetsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do your testing here.

            Console.ReadKey();
        }
    }
    public class CoffeeShop
    {
        // TODO: Implement coffee shop without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<Coffee, int> _coffees = new Dictionary<Coffee, int>();
        Queue<int> _customers = new Queue<int>();
        int _ticket = 1;
        int _coffeesServed = 0;

        public CoffeeShop(Coffee[] coffeesPrepared)
        {
            // TODO: Remove throw new NotImplementedException. Add coffees to coffee dictionary.

            foreach (var coffee in coffeesPrepared)
            {
                if (_coffees.ContainsKey(coffee))
                {
                    _coffees[coffee]++;
                    //_coffees[coffee] = _coffees[coffee]+1;
                }else
                {
                    _coffees.Add(coffee, 1);
                }
            }

        }
        public CoffeeShop(Coffee[] coffeesPrepared, int customersInQueue) : this(coffeesPrepared)
        {
            // TODO: Remove throw new NotImplementedException. Add customers to queue with their ticket number. 

            for (int i = 1; i < customersInQueue; i++)
            {
                _customers.Enqueue(i);
            }

          
        }

        public void AddCustomer()
        {
            // TODO: Add customer to queue.

            _customers.Enqueue(NextTicket);
            
        }

        public bool ServeCustomer(Coffee coffee)
        {
            // TODO: remove customer from queue and give him coffee. If coffee not yet made do nothing and return false.
            throw new NotImplementedException();
        }

        public bool AddCoffee(Coffee coffee)
        {
            // TODO: Add prepared coffee.
            throw new NotImplementedException();


        }

        public bool RemoveCoffee(Coffee coffee)
        {
            // TODO: Subtract given coffee
            throw new NotImplementedException();
        }

        public int[] Customers
        {
            
            get
            {

                // TODO: Return ticket numbers of people in queue.
                throw new NotImplementedException();
            }

        }

        public int NextTicket
        {
            get
            {
                // TODO: return next ticket.
                return _ticket;
            }
        }

        public int CoffeesServed
        {
            get
            {
                // TODO: Track all coffees served & their count.
                return _coffeesServed;
            }
        }

        public int CustomersServed
        {
            get
            {
                // TODO: Track all customers served.
                throw new NotImplementedException();
            }
        }

        public Dictionary<Coffee, int> CoffeesReadyToServe
        {
            get
            {
                // TODO: Track all currently availbale coffees.
                throw new NotImplementedException();
            }
        }

        public Queue<int> CustomersInQueue
        {
            get
            {
                // TODO: Return customers.
                return _customers;
            }
        }

    }
}
