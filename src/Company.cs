using System;
using System.Collections.Generic;


namespace src
{
    public class Company
    {
        public decimal[] currentAssets { get; }
        public decimal[] currentLiabilities { get; }
        public decimal[] longTermRealizableAssets { get; }
        public decimal[] longTermChargeableLiabilities { get; }
        public decimal[] availability { get; }
        public decimal[] stock { get; }
        public decimal[] netProfit { get; }
        public decimal[] netWorth { get; }
        public decimal[] fixedAssets { get; }
        public decimal[] grossProfit { get; }
        public decimal[] netSales { get; }
        public decimal[] stocksAmount { get; }
        
        public Company(decimal[] currentassets, decimal[] currentliabilities, decimal[] longtermrealizableassets,
        decimal[] longtermcharheableliabilities, decimal[] Availability, decimal[] Stock, decimal[] netprofit,
        decimal[] networth, decimal[] fixedassets, decimal[] grossprofit, decimal[] netsales, decimal[] stocksamount){
            
            this.currentAssets = currentassets;
            this.currentLiabilities = currentliabilities;
            this.longTermRealizableAssets = longtermrealizableassets;
            this.longTermChargeableLiabilities = longtermcharheableliabilities;
            this.availability = Availability;
            this.stock = stock;
            this.netProfit = netprofit;
            this.fixedAssets = fixedassets;
            this.grossProfit = grossprofit;
            this.netSales = netsales;
            this.stocksAmount = stocksamount;
        }

        public List<decimal> LC()
        {
            var LCs = new List<decimal>();

            for(int i = 0; i < currentAssets.Length; i++)
            {
                LCs[i] = currentAssets[i] / currentLiabilities[i];
            }

            return LCs;
        }


    }
}