//Section 1: Type Annotations & Functions
//Task 1: Implement a Utility Function

function capitalizeWords(input: string): string {
    if (!input.trim()) return ""; // Handle empty
  
    return input
      .split(" ")
      .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
      .join(" ");
  }

  console.log(capitalizeWords("HELLO")); 


//Task 2: Number Validator Function
function isValidNumber(value: unknown): boolean {
    return typeof value === "number" && !isNaN(value) && isFinite(value);
  }

  console.log(isValidNumber(30));
  console.log(isValidNumber("30"));

//Section 2: Interfaces & Object Types
//Task 3: Create a User System

interface User {
  id: number;
  name: string;
  email: string;
  isAdmin?: boolean; 
}

function createUser(user: User): string {
    return `User ${user.name} created successfully`;
  }

const user1: User = {id: 1,name: "Renad Alhazmi",email: "user@example.com",};
console.log(createUser(user1)); 


//Section 3: Classes & OOP
//Task 4: Implement a Product Class

class Product {

    public name: string;
    public category: string;
    private price: number; 
  
    constructor(name: string, price: number, category: string) {
      this.name = name;
      this.price = price;
      this.category = category;
    }
    // calculate discounted price
    public getDiscountedPrice(discount: number): number {
      if (discount < 0 || discount > 100) {
        throw new Error("Discount must be between 0 and 100");
      }
      return this.price - (this.price * discount) / 100;
    }
  }

const product = new Product("Laptop", 1500, "Electronics");
console.log(`Discounted Price: $${product.getDiscountedPrice(20)}`); 



//Section 4: Generics & Utility Types
//Task 5: Implement a Generic Function

function filterArray<T>(arr: T[], predicate: (item: T) => boolean): T[] {
    return arr.filter(predicate);
}

const numbers = [1, 2, 3, 4, 5, 6];
// Condition: Keep only even numbers
const evenNumbers = filterArray(numbers, (num) => num % 2 === 0);
console.log(evenNumbers); // Output: [2, 4, 6]


//Section 5: TypeScript with Async/Await
//Task 6: Fetch & Display Users

interface User {
    id: number;
    name: string;
    email: string;
  }
  
  async function fetchUsers() {
    try {
      const response = await fetch("https://jsonplaceholder.typicode.com/users");
      const data = await response.json();

      return data.map((user: any) => ({
        id: user.id,
        name: user.name,
        email: user.email,
      }));
    } catch (error) {
      console.error("Failed to fetch users:", error);
      return [];
    }
  }
  
fetchUsers().then(users => console.log(users));


