
# Veterinary Appointment App 🐾

XamarinVet is a mobile app designed for veterinary appointments. It helps pet owners book appointments for their animals, track their age, and select the type of pet they have. The app provides an easy-to-use interface for scheduling, tracking, and managing appointments.

## Features:
Pet selection (Dog, Cat, Guinea Pig)

Age selection via slider

Appointment scheduling with time and purpose

User-friendly interface for pet owners

## SOLID Principles in XamarinVet
The SOLID principles are incorporated into the design of XamarinVet to ensure clean, maintainable, and scalable code. Here's how each principle has been applied:

1. Single Responsibility Principle (SRP)
Each class and component in the XamarinVet app has one responsibility. For example:

The MainPage class handles UI interactions such as pet selection, slider value change, and button clicks.

The slider’s value change is processed by a separate method that updates the pet’s age, ensuring each function is responsible for a single task.

2. Open/Closed Principle (OCP)
The app is designed to allow new features to be added without modifying the core code. For instance:

New pet types can be added easily by extending the functionality of the pet selection logic, without needing to alter existing code.

You can extend the app with additional pet-related features (e.g., adding new pet health checks) by creating new classes or services that don’t require changes to the existing pet models.

3. Liskov Substitution Principle (LSP)
The app follows Liskov Substitution by ensuring that objects of a superclass can be substituted with objects of subclasses without altering the behavior. For example:

If additional types of pets (such as birds or reptiles) are added in the future, they can be substituted in the same interface used by the current pets (dog, cat, guinea pig) without affecting the app’s correctness.

4. Interface Segregation Principle (ISP)
The app’s interfaces are small and focused on specific actions. For example:

We avoid large, monolithic interfaces and instead use focused interfaces that only expose the necessary functionality. This ensures that the app components that don't need to interact with a specific behavior are not forced to depend on it.

5. Dependency Inversion Principle (DIP)
The app uses abstractions rather than concrete implementations for services, such as data management or API calls. For example:

The app’s data services depend on abstractions, such as IPetService and IAppointmentService, which are then implemented by concrete classes that handle the data fetching and storage operations.

Getting Started
To run this app, clone the repository and open the solution in Visual Studio or Xamarin Studio.

Prerequisites
Xamarin

.NET MAUI (or Xamarin.Forms for older versions)

Visual Studio with Xamarin support

## Contributing
Feel free to fork the repository, make your changes, and submit a pull request. Contributions are always welcome!

## Design & Language

The UI/UX was implemented based on a static design image mockup.  
The app interface and text are in **Polish**.

## Author

Created by [@kamilka-g](https://github.com/kamilka-g)  
Software technician student passionate about cloud and app development.

Feel free to use my code for educational purposes :)
