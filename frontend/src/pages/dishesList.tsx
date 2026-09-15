import DishCard from "@/components/ui/dishCard";
import SkeletonCard from "@/components/ui/skeletonCard";
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
//import { useDishes } from "@/hooks/useDishes";

export type Dish = {
  id: number;
  title: string;
  image_url: string;
};

const dishes: Dish[] = [];

for (let i = 0; i < 20; i++) {
  dishes.push({
    id: i,
    title: "Dish Title",
    image_url:
      "https://avatars.mds.yandex.net/i?id=cff33092ec24f68b9d0496c444ecbfc6290f1ec9-5460185-images-thumbs&n=13",
  });
}

export default function DishesList() {
  //const { data: dishes, isPending, isError, error } = useDishes()
  
  return (
    <Tabs className="dark" defaultValue="Main_dishes">
      <TabsList className="bg-inherit my-2">
        <TabsTrigger value="Main_dishes">Основные блюда</TabsTrigger>
        <TabsTrigger value="second">Второе</TabsTrigger>
      </TabsList>
      <TabsContent className="grid grid-cols-2" value="Main_dishes">
        {dishes.length
          ? dishes.map((dish) => <DishCard key={dish.id} {...dish} />)
          : Array.from({ length: 20 }, (_, i) => <SkeletonCard key={i} />)}
      </TabsContent>
      <TabsContent value="second">Второе</TabsContent>
    </Tabs>
  );
}
