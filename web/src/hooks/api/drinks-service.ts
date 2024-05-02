// import {useMutation, useQuery} from "@tanstack/react-query";
// import {apiBaseUrl} from "../../utils/vite-env";
// import {Drink, DrinkForm, PagedDrinksResponse} from "../../types/api/drinks";
//
// const fetchDrink = async (id: string): Promise<Drink> => {
//   const response = await fetch(`${apiBaseUrl}/${id}`);
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const useDrink = (id: string) => {
//   return useQuery<Drink, Error>({
//     queryKey: ['drink', id],
//     queryFn: () => fetchDrink(id),
//     enabled: !!id,
//   });
// }
//
// const fetchDrinks = async (): Promise<Drink[]> => {
//   const response = await fetch(apiBaseUrl);
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const useDrinks = () => {
//   return useQuery<Drink[], Error>({
//     queryKey: ['drinks'],
//     queryFn: fetchDrinks,
//   });
// }
//
// const fetchPagedDrinks = async (pageNum: number, pageSize: number, filter: string): Promise<PagedDrinksResponse> => {
//   const url = new URL(`${apiBaseUrl}/paged`);
//   url.searchParams.append('pageNum', pageNum.toString());
//   url.searchParams.append('pageSize', pageSize.toString());
//   url.searchParams.append('filter', filter);
//
//   const response = await fetch(url.toString());
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const usePagedDrinks = (pageNum: number, pageSize: number, filter: string) => {
//   return useQuery<PagedDrinksResponse, Error>({
//     queryKey: ['pagedDrinks', pageNum, pageSize, filter],
//     queryFn: () => fetchPagedDrinks(pageNum, pageSize, filter),
//     enabled: !!pageNum && !!pageSize,
//   });
// }
//
// const createDrink = async (drink: DrinkForm) => {
//   const response = await fetch(apiBaseUrl, {
//     method: 'POST',
//     headers: {'Content-Type': 'application/json'},
//     body: JSON.stringify(drink)
//   });
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const useCreateDrink = () => {
//   return useMutation({mutationFn: createDrink});
// }
//
// const updateDrink = async (id: string, drink: DrinkForm) => {
//   const response = await fetch(`${apiBaseUrl}/${id}`, {
//     method: 'POST',
//     headers: {'Content-Type': 'application/json'},
//     body: JSON.stringify(drink)
//   });
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const useUpdateDrink = () => {
//   return useMutation({mutationFn: updateDrink});
// }
//
// const deleteDrink = async (id: string) => {
//   const response = await fetch(`${apiBaseUrl}/${id}`, {
//     method: 'DELETE',
//   });
//   if (!response.ok) throw new Error('There was a problem receiving the network response.');
//   return response.json();
// }
//
// export const useDeleteDrink = () => {
//   return useMutation({mutationFn: deleteDrink});
// }