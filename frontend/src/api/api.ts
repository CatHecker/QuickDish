const API_URL = "http://localhost:5000";

export const queryKeys = {
  dishes: {
    all: ["dishes"] as const,
    list: (filters?: DishFilters) =>
      [...queryKeys.dishes.all, "list", filters] as const,
    detail: (id: string) => [...queryKeys.dishes.all, "detail", id] as const,
  },
} as const;

export async function apiFetch<T>(
  endpoint: string,
  options?: RequestInit,
): Promise<T> {
  const response = await fetch(`${API_URL}${endpoint}`, {
    headers: { "Content-Type": "application/json" },
    ...options,
  });

  if (!response.ok) {
    const error = await response
      .json()
      .catch(() => ({ message: "Unknown error" }));
    throw new Error(error.message || `HTTP ${response.status}`);
  }

  return response.json();
}

export interface DishFilters {
  category?: string;
  search?: string;
}
