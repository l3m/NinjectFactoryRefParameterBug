# Ninject Factory Bug

This project exists to reproduce a bug in the Ninject Factory extension. When auto-generating a factory with ref parameters, such as this: 

    public interface IDemoFactory
    {
		IDemo CreateDemo(ref int x);
    }

an Exception is thrown when attempting to create an instance using the factory: 

    System.InvalidProgramException: Common Language Runtime detected an invalid program.  


To reproduce, you can either run the njfbug console app in Visual Studio, or build the solution and then run 
	
	bin/Debug/njfbug.exe


 



