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
        public decimal[] stocksQuote { get; }
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
        public List<decimal> LG()
        {
            var LGs = new List<decimal>();

            for(int i = 0; i < currentAssets.Length; i++)
            {
                LGs[i] = (currentAssets[i] + longTermRealizableAssets[i])/(currentLiabilities[i] + longTermChargeableLiabilities[i]);
            }
            return LGs;
        }
        public List<decimal> LI()
        {
            var LIs = new List<decimal>();

            for(int i = 0; i < availability.Length; i++)
            {
                LIs[i] = availability[i]/currentLiabilities[i];
            }
            return LIs;
        }
        public List<decimal> LS()
        {
            var LSs = new List<decimal>();

            for(int i = 0; i < currentAssets.Length; i++)
            {
                LSs[i] = (currentAssets[i] + stock[i])/currentLiabilities[i];
            }
            return LSs;
        }
        public List<decimal> RPL()
        {
            var RPLs = new List<decimal>();

            for(int i = 0; i < netProfit.Length; i++)
            {
                RPLs[i] = netProfit[i]/netWorth[i];
            }
            return RPLs;
        }
        public List<decimal> GE()
        {
            var GEs = new List<decimal>();

            for(int i = 0; i < longTermChargeableLiabilities.Length; i++)
            {
                GEs[i] = longTermChargeableLiabilities[i]/(currentAssets[i]+fixedAssets[i]+longTermRealizableAssets[i]);
            }
            return GEs;
        }
        public List<decimal> IF()
        {
            var IFs = new List<decimal>();

            for(int i = 0; i < netWorth.Length; i++)
            {
                IFs[i] = netWorth[i]/(currentAssets[i]+fixedAssets[i]+longTermRealizableAssets[i]);
            }
            return LIs;
        }
        public List<decimal> MB()
        {
            var MBs = new List<decimal>();

            for(int i = 0; i < grossProfit.Length; i++)
            {
                MBs[i] = grossProfit[i]/netSales[i];
            }
            return MBs;
        }
        public List<decimal> ML ()
        {
            var MLs = new List<decimal>();

            for(int i = 0; i < netWorth.Length; i++)
            {
                MLs[i] = netProfit[i]/netSales[i];
            }
            return MLs;
        }
        public List<decimal> LPA()
        {
            var LPAs = new List<decimal>();

            for(int i = 0; i < netProfit.Length; i++)
            {
                LPAs[i] = netProfit[i]/stocksAmount[i];
            }
            return LPAs;
        }
        public List<decimal> VPA()
        {
            var VPAs = new List<decimal>();

            for(int i = 0; i < netWorth.Length; i++)
            {
                VPAs[i] = netWorth[i]/stocksAmount[i];
            }
            return VPAs;
        }
        public List<decimal> PL()
        {
            var PLs = new List<decimal>();
            var lpas = this.LPA();

            for(int i = 0; i < stocksQuote.Length; i++)
            {
                PLs[i] = stocksQuote[i]/lpas[i];
            }
            return PLs;
        }
        public List<decimal> TR()
        {
            var TRs = new List<decimal>();
            var pl = this.PL();

            for(int i = 0; i < stocksQuote.Length; i++)
            {
                TRs[i] = 1/pl[i];
            }
            return TRs;
        }
        public List<decimal> PVP()
        {
            var PVPs = new List<decimal>();
            var vpa = this.VPA();

            for(int i = 0; i < stocksQuote.Length; i++)
            {
                PVPs[i] = stocksQuote[i]/vpa[i];
            }
            return PVPs;
        }
        public List<decimal> PSR()
        {
            var PSRs = new List<decimal>();
            
            for(int i = 0; i < stocksQuote.Length; i++)
            {
                PSRs[i] = stocksQuote[i] / (netSales[i]/stocksAmount[i]);  
            }
            return PSRs;
        }
    }
}