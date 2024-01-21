import { Pipe, PipeTransform } from '@angular/core';
import { environment } from '../../environments/environment';

@Pipe({
  name: 'imageUrl',
  standalone: true
})
export class ImageUrlPipe implements PipeTransform {
  transform(value: string | undefined): string {
    if (!value) {
      return 'https://placehold.co/600x400';
    }
    return `${environment.apiUrl}\\${value}`;
  }
}
