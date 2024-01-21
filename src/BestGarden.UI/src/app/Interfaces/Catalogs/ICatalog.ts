import { IProduct } from "../Products/IProduct";

export interface ICatalog {
    id: number;
    name: string;
    description: string;
    plantSystem: string;
    imagePath: string;
    products: IProduct[];
}