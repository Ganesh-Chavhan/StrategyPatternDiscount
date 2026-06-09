# Strategy Pattern - Discount Calculator System

## Overview

This project demonstrates the **Strategy Design Pattern** in C# using a simple Discount Calculator System.

Different customer types receive different discount percentages. Instead of using large if-else statements, each discount calculation is implemented as a separate strategy class and can be selected at runtime.

---

## Design Pattern Used

### Strategy Pattern

The Strategy Pattern allows us to define multiple algorithms, place each algorithm in a separate class, and switch between them dynamically at runtime.

---

## Project Structure

```text
StrategyPatternDiscount
│
├── IDiscountStrategy.cs
├── DiscountStrategies.cs
├── DiscountCalculator.cs
└── Program.cs
```

---

## Components

### Strategy Interface
- IDiscountStrategy

Defines the common method used by all discount strategies.

```csharp
double CalculateDiscount(double amount);
```

---

### Concrete Strategies

#### RegularDiscount
Provides 5% discount.

#### StudentDiscount
Provides 10% discount.

#### PremiumDiscount
Provides 20% discount.

---

### Context

#### DiscountCalculator

Uses the selected discount strategy to calculate the final amount.

---

### Client

#### Program.cs

Accepts user input, selects the appropriate strategy, and calculates the final bill amount.

---

## How It Works

1. User enters the purchase amount.
2. User selects a customer type.
3. The corresponding discount strategy is chosen.
4. The Discount Calculator applies the selected strategy.
5. Final amount is displayed.

---

## Sample Input

```text
Enter Purchase Amount: 1000

1. Regular Customer
2. Student Customer
3. Premium Customer

Choose Customer Type: 2
```

---

## Sample Output

```text
Final Amount: Rs. 900
```

---

## Benefits of Strategy Pattern

- Eliminates large if-else blocks
- Supports runtime behavior changes
- Easy to add new discount types
- Promotes code reusability
- Follows Open/Closed Principle

---

## Real-World Applications

- Payment methods (UPI, Credit Card, PayPal)
- Navigation routes (Car, Bike, Walking)
- Discount systems
- Tax calculation systems
- Sorting algorithms

---

## Technologies Used

- C#
- Visual Studio

---

## Author

Ganesh Chavhan
