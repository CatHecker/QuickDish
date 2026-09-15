import { apiFetch, queryKeys, type DishFilters } from '@/api/api'
import type { Dish } from '@/pages/dishesList'
import { useQuery } from '@tanstack/react-query'

export function useDishes(filters?: DishFilters) {
  return useQuery<Dish[], Error>({
    queryKey: queryKeys.dishes.list(filters),
    queryFn: async () => {
      const params = new URLSearchParams()
      if (filters?.category) params.set('category', filters.category)
      if (filters?.search) params.set('search', filters.search)

      const query = params.toString()
      return apiFetch<Dish[]>(`/api/dishes${query ? `?${query}` : ''}`)
    },
  })
}