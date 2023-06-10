using ArganaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ArganaRestaurant.Commands
{
    public class OrderItemQuantityCommand : CommandBase
    {

        private readonly ProductViewModel currentItem;
        private readonly string operation;


        public OrderItemQuantityCommand(ProductViewModel item, string op) 
        { 
            currentItem = item;
            operation = op.ToUpper();
        }



        public override void Execute(object? parameter)
        {
            if (operation == "PLUS")
            {
                currentItem.Quantity++;
            }
            else if (operation == "MINUS" && currentItem.Quantity > 0)
            {
               currentItem.Quantity--;
            }
        }


    }
}
