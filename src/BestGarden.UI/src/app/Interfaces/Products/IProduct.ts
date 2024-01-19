export interface IProduct {
    id: number;
    name: string;
    description?: string;
    imagePath: string;
    price?: number;
    catalogId?: number;
}