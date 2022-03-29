import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  close() {
    let navOptions = document.getElementById('options')
    if (navOptions?.classList.toString() == "options"){
      navOptions.classList.remove("options")
      navOptions.classList.toggle("optionsClosed")
    }
  }

}
