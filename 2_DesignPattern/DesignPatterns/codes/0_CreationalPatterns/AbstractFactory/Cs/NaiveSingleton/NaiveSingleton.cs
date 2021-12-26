namespace Singleton
{

    /*  
     *  The Singleton should always be a 'sealed' class to prevent class
     *  inheritance through external classes and also through nested classes.
     */
    public sealed class NaiveSingleton
    {

        #region FIELD & PROPERTY

        /*
         * The instance of Singleton is stored in a static field.
         */
        private static NaiveSingleton _instance;

        #endregion



        #region CONSTRUCTOR

        /*
         * The Singleton's constructor should always be private to prevent
         * direct construction calls with the `new` operator.
         */
        private NaiveSingleton()
        {

        }

        #endregion



        #region METHOD

        /*
         * This is the static method that controls the access to the Singleton instance.
         */
        public static NaiveSingleton GetInstance()
        {
            //on the 1st run, it creates a singleton object and place in the static field
            if (_instance == null)
            {
                _instance = new NaiveSingleton();
            }
            return _instance;  //it returns the only-one singleton instance
        }

        /*
         * Here you can define some businees logic and operation, which can be executed on its instance
         */
        public static void SomeOperation()
        {
            //...
        }


        #endregion






    }
}
