using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entities.Components;

namespace Entities
{
    [Serializable]
    public class Stock<T>
    {
        public T t;
        public int amount;

        public Stock()
        {

        }

        public Stock(T t, int amount)
        {
            this.t = t;
            this.amount = amount;
        }

        public T GetT
        {
            get
            {
                return this.t;
            }
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }
        }

        public void SubstractAmount()
        {
            if(this.amount > 0)
            {
                this.amount--;
            }
        }

        public void SubstractAmount(int amountToSubstract)
        {
            this.amount -= amountToSubstract;
        }

        public void AddAmount()
        {
            this.amount++;
        }
        public void AddAmount(int amountToAdd)
        {
            this.amount += amountToAdd;
        }
    }
}