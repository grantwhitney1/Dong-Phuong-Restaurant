import {create, StoreApi, UseBoundStore} from "zustand";

export const useUserStore: UseBoundStore<StoreApi<{
  user: { email: string, isAuthenticated: boolean },
  setUser: (user: { email: string, isAuthenticated: boolean }) => void
}>> = create(set => ({
  user: {
    email: '',
    isAuthenticated: false,
  } as { email: string, isAuthenticated: boolean },
  setUser: (user: { email: string, isAuthenticated: boolean }) => set({user}),
}))