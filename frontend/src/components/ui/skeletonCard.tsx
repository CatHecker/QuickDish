import { Card, CardHeader } from "./card";
import { Skeleton } from "./skeleton";

export default function SkeletonCard() {
  return (
    <Card className="bg-red-950 m-3 overflow-hidden hover:shadow-lg transition-shadow cursor-pointer ring-0">
      <Skeleton className="aspect-video h-full w-full" />
      <CardHeader>
        <Skeleton className="h-4 w-2/3" />
      </CardHeader>
    </Card>
  );
}
