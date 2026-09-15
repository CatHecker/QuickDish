import type { Dish } from "@/pages/dishesList";
import { Link } from "react-router";
import { Card, CardHeader, CardTitle } from "./card";

export default function DishCard({ image_url, title, id }: Dish) {



  return (
    <Link to={`/dishes/${id}`}>
      <Card className="bg-red-950 m-3 overflow-hidden hover:shadow-lg transition-shadow cursor-pointer ring-0">
        <img
          src={image_url} 
          alt={title}
          className="w-full h-full object-cover transition-transform hover:scale-105"
        />
        <CardHeader>
          <CardTitle>{title}</CardTitle>
        </CardHeader>
      </Card>
    </Link>
  );
}
