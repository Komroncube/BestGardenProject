import { environment } from "../../../environments/environment";

export class ProductInfo {
    Id!: number;
    Name!: string;
    ImagePath!: string;

    /**
     *
     */
    constructor(id: number, name: string, imagePath: string) {
        this.Id = id;
        this.Name = name;
        this.ImagePath = imagePath;
    }
    get imagePath() {
        return `${environment.apiUrl}\\${this.ImagePath}`;
    }
    
    
}