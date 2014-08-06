package client;

import java.rmi.RemoteException;

import javax.xml.rpc.ServiceException;

import demo.HelloWorld;
import demo.HelloWorldService;
import demo.HelloWorldServiceLocator;

public class ClientSOA {
public static void main(String [] arg) throws ServiceException, RemoteException{
	HelloWorldService t = new HelloWorldServiceLocator();
	HelloWorld port = t.getHelloWorld();
	System.out.println(port.saluer("Bouanga"));
}
}
