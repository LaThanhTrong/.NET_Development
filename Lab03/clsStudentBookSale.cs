class clsStudentBookSale:clsBookSale
{
    bool blnStudentDiscount;
    const float sgnStudentDiscountRate = 0.15f;

    public bool StudentDiscount
    {
        get { return blnStudentDiscount; }
        set { blnStudentDiscount = value; }
    }

    public clsStudentBookSale(string strTitle, int intQuantity, decimal decPrice, bool blnDiscount, bool blnStudentDiscount)
        : base(strTitle, intQuantity, decPrice, blnDiscount)
    {
        this.blnStudentDiscount = blnStudentDiscount;
    }

    public override decimal DiscountAmount()
    {
        decimal decDiscountAmount = 0;
        decDiscountAmount = base.DiscountAmount();
        if (StudentDiscount)
        {
            decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sgnStudentDiscountRate);
        }
        return decDiscountAmount;
    }   
}













