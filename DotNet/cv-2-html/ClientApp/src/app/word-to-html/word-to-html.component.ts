import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'word-to-html',
  templateUrl: './word-to-html.component.html',
  styleUrls: ['./word-to-html.component.css']
})
export class WordToHtmlComponent {
  public result: boolean;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<boolean>(baseUrl + 'api/WordToHTML/Convert').subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }
}
