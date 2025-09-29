using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{
	// Criado com Exception > tab 2x
	[Serializable]
	public class ByteBankException : Exception
	{
        //Construtor padrão que cria a exceção sem mensagem.
        public ByteBankException() { }

        //Construtor que aceita uma mensagem de erro personalizada.
        public ByteBankException(string message) : base("Aconteceu um erro -> " + message) { }

        //Construtor que aceita uma mensagem e uma exceção interna (inner exception), útil para encadear erros e preservar a pilha de chamadas original.
        public ByteBankException(string message, Exception inner) : base(message, inner) { }

        //Esse é o construtor de desserialização, necessário para que a exceção funcione corretamente em processos de serialização/desserialização.
		//Normalmente é exigido quando você marca a exceção como[Serializable].
		protected ByteBankException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
