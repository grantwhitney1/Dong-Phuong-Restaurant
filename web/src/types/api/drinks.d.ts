export type DrinkForm = {
  name: string,
  size: string,
  price: number,
}

export type Drink = DrinkForm;

export type PagedDrinksResponse = Array<Drink>;