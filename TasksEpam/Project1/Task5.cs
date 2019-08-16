namespace TasksEpam.Project1
{
    class ComplexNumber
    {
        #region Properties
        public double Real { get; set; }
        public double Imaginary { get; set; }
        #endregion
        #region Constructors
        public ComplexNumber()
        {
        }
        public ComplexNumber(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        #endregion
        #region Methods
        //i^2 = -1
        //(a+bi)(c+di) = (ac-bd) + (ad+bc)i 
        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            return new ComplexNumber(cn1.Real * cn2.Real - cn1.Imaginary * cn2.Imaginary,
                                 cn1.Real * cn2.Imaginary + cn2.Real * cn1.Imaginary);
        }
        //(a+bi)/(c+di) = (ac+bd)/(c^2+d^2)+(cb-ad)/(c^2+d^2)
        public static ComplexNumber operator /(ComplexNumber cn1, ComplexNumber cn2)
        {
            if (cn2.Real == 0.0 && cn2.Imaginary == 0.0)
                throw new System.DivideByZeroException();
            else
            {
                double r_numerator = cn1.Real * cn2.Real + cn1.Imaginary * cn2.Imaginary;
                double i_numerator = cn2.Real * cn1.Imaginary - cn1.Real * cn2.Imaginary;
                double denominator = cn2.Real * cn2.Real + cn2.Imaginary * cn2.Imaginary;

                double real = r_numerator / denominator;
                double imaginary = i_numerator / denominator;

                return (new ComplexNumber(real, imaginary));
            }            
        }

        public override string ToString() => $"{Real} {Imaginary}";
        #endregion
    }
}
