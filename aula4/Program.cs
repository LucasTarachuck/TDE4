double totalPedido = 0;
bool pedidoAberto = true;

while(pedidoAberto){
    Console.WriteLine("Bem vindo ao melhor sitema de pedidos da Ulbra Torres");
    Console.WriteLine("1: Adicionar item ao pedido");
    Console.WriteLine("2: Exibir total dopedido");
    Console.WriteLine("3: Finalizar pedido e sair");
    
    string opc = Console.ReadLine();

    switch(opc){
        case "1":
        Console.WriteLine("Escoha um item do cardápio");
        Console.WriteLine("Pizza: R$30,00");
        Console.WriteLine("Hamburger: R$15,00");
        Console.WriteLine("Refrigerante: R$5,oo");
        string escolha = Console.ReadLine();
        if (escolha == "1"){
            Console.WriteLine("Você adicoonou uma pizza");
            totalPedido +=30;
        }
        else if(escolha == "2"){
            Console.WriteLine("Você adicoonou um hamburger");
            totalPedido += 15;
        }
        else if(escolha == "3"){
            Console.WriteLine("Você adicoonou um refrigerante");
            totalPedido += 55;
        }
        else{
            Console.WriteLine("Escolha uma opção válida");
        }
        break;
        case "2":
        Console.WriteLine($"O total do pedido deu: {totalPedido}");
        break;
        case "3":
        Console.WriteLine("Volte sempre e obrigado por utilizar o melhor sistema de gerenciamento de pedidos da Ulbra Torres");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Digite uma opção válida");
        break;
    }
}
