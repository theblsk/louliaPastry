import { style } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { allMenu } from '../APIReceipt';
import { HtmlAstPath } from '@angular/compiler';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor(private apiCaller: HttpClient, public menu : allMenu) {

  }

  ngOnInit(): void {
    this.apiCaller.get('https://loulia-api.herokuapp.com/api/menu/eclaire')
    .subscribe((res: any) =>{ 
      console.log(res)
      this.menu.eclaire = res;
    })
    this.apiCaller.get('https://loulia-api.herokuapp.com/api/menu/cookie')
    .subscribe((res: any) =>{ 
      console.log(res)
      this.menu.cookie = res;
    })
    this.apiCaller.get('https://loulia-api.herokuapp.com/api/menu/icecream')
    .subscribe((res: any) =>{ 
      console.log(res)
      this.menu.icecream = res;
    })
    this.apiCaller.get('https://loulia-api.herokuapp.com/api/menu/brownie')
    .subscribe((res: any) =>{ 
      console.log(res)
      this.menu.brownie = res;
    })
    this.apiCaller.get('https://loulia-api.herokuapp.com/api/menu/specialbites')
    .subscribe((res: any) =>{ 
      console.log(res)
      this.menu.specialBites = res;
    })
  }
  
  chooseOne(entry:string){
 
    let menu = document.getElementById('menuContent')
    let notChoice = menu?.querySelectorAll(`div:not([data-target='${entry}'])`)
    notChoice?.forEach(item=>{
      let extract = item as HTMLElement
      if (extract.classList.toString() == "menuItem")
      {
        extract.classList.remove("menuItem")
        extract.classList.toggle("menuItemHidden")
      }
    })
    let choice = menu?.querySelectorAll(`[data-target='${entry}']`)
    choice?.forEach(item => {
      let extract = item as HTMLElement
      if (extract.classList.toString() == "menuItemHidden")
      {
        extract.classList.remove("menuItemHidden")
        extract.classList.toggle("menuItem")
      }
    })
    
  }
  salt(){

  }

}
