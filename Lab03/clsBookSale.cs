class clsBookSale
{
    string strTitle;
    int intQuantity;
    decimal decPrice;
    static decimal decSalesTotal = 0;
    static int intSalesCount = 0;
    const float sngDiscountRate = 0.1f;
    bool blnDiscount;

    public clsBookSale(string strTitle, int intQuantity, decimal decPrice, bool blnDiscount)
    {
        this.strTitle = strTitle;
        this.intQuantity = intQuantity;
        this.decPrice = decPrice;
        this.blnDiscount = blnDiscount;
    }

    public String Title
    {
        get { return strTitle; }
        set { strTitle = value; }
    }

    public int Quantity
    {
        get { return intQuantity; }
        set
        {
            if (value > 0)
            {
                intQuantity = value;
            }
            else
                throw new Exception();
        }
    }

    public decimal Price
    {
        get { return decPrice; }
        set
        {
            if (value > 0)
            {
                decPrice = value;
            }
            else
                throw new Exception();
        }
    }

    public static decimal SalesTotal
    {
        get { return decSalesTotal; }
    }

    public static int SalesCount
    {
        get { return intSalesCount; }
    }

    public bool Discount
    {
        get { return blnDiscount; }
        set { blnDiscount = value; }
    }

    public decimal ExtendedPrice()
    {
        decimal decExtendedPrice = intQuantity * decPrice;
        decSalesTotal += decExtendedPrice;
        intSalesCount += 1;
        return decExtendedPrice;
    }
    
    public virtual decimal DiscountAmount()
    {
        decimal decDiscountAmount;
        if (blnDiscount)
        {
            decDiscountAmount = ExtendedPrice() * Convert.ToDecimal(sngDiscountRate);
        }
        else
        {
            decDiscountAmount = 0M;
        }
        return decDiscountAmount;
    }
    public decimal NetDue()
    {
        decimal decNextDue = ExtendedPrice() - DiscountAmount();
        decSalesTotal += decNextDue;
        intSalesCount += 1;
        return decNextDue;
    }
}

