using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class BurgerBuilder
    {
        private Burger _burger = new Burger();

        public BurgerBuilder SetBun(string bun)
        {
            _burger.Bun = bun;
            return this;
        }

        public BurgerBuilder SetPatty(string patty)
        {
            _burger.Patty = patty;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            _burger.Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return _burger;
        }
    }

}
