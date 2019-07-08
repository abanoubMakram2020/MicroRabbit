using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int TransferFrom { get; set; }
        public int TransferTo { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
