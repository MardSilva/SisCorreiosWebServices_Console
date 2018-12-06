//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisCorreiosPrecoPrazo {
	using System;
	using System.Web.Services;
	using System.Diagnostics;
	using System.Web.Services.Protocols;
	using System.Xml.Serialization;
	using System.ComponentModel;
	
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="CalcPrecoPrazoWSSoap", Namespace="http://tempuri.org/")]
	public partial class CalcPrecoPrazoWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
		
		/// <remarks/>
		public CalcPrecoPrazoWS() {
			this.Url = "http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx";
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoPrazo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrecoPrazo(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
			object[] results = this.Invoke("CalcPrecoPrazo", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrecoPrazo(
					string nCdEmpresa, 
					string sDsSenha, 
					string nCdServico, 
					string sCepOrigem, 
					string sCepDestino, 
					string nVlPeso, 
					int nCdFormato, 
					decimal nVlComprimento, 
					decimal nVlAltura, 
					decimal nVlLargura, 
					decimal nVlDiametro, 
					string sCdMaoPropria, 
					decimal nVlValorDeclarado, 
					string sCdAvisoRecebimento, 
					System.AsyncCallback callback, 
					object asyncState) {
			return this.BeginInvoke("CalcPrecoPrazo", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrecoPrazo(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoPrazoData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrecoPrazoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
			object[] results = this.Invoke("CalcPrecoPrazoData", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrecoPrazoData(
					string nCdEmpresa, 
					string sDsSenha, 
					string nCdServico, 
					string sCepOrigem, 
					string sCepDestino, 
					string nVlPeso, 
					int nCdFormato, 
					decimal nVlComprimento, 
					decimal nVlAltura, 
					decimal nVlLargura, 
					decimal nVlDiametro, 
					string sCdMaoPropria, 
					decimal nVlValorDeclarado, 
					string sCdAvisoRecebimento, 
					string sDtCalculo, 
					System.AsyncCallback callback, 
					object asyncState) {
			return this.BeginInvoke("CalcPrecoPrazoData", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrecoPrazoData(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoPrazoRestricao", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrecoPrazoRestricao(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
			object[] results = this.Invoke("CalcPrecoPrazoRestricao", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrecoPrazoRestricao(
					string nCdEmpresa, 
					string sDsSenha, 
					string nCdServico, 
					string sCepOrigem, 
					string sCepDestino, 
					string nVlPeso, 
					int nCdFormato, 
					decimal nVlComprimento, 
					decimal nVlAltura, 
					decimal nVlLargura, 
					decimal nVlDiametro, 
					string sCdMaoPropria, 
					decimal nVlValorDeclarado, 
					string sCdAvisoRecebimento, 
					string sDtCalculo, 
					System.AsyncCallback callback, 
					object asyncState) {
			return this.BeginInvoke("CalcPrecoPrazoRestricao", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrecoPrazoRestricao(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPreco", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPreco(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
			object[] results = this.Invoke("CalcPreco", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPreco(
					string nCdEmpresa, 
					string sDsSenha, 
					string nCdServico, 
					string sCepOrigem, 
					string sCepDestino, 
					string nVlPeso, 
					int nCdFormato, 
					decimal nVlComprimento, 
					decimal nVlAltura, 
					decimal nVlLargura, 
					decimal nVlDiametro, 
					string sCdMaoPropria, 
					decimal nVlValorDeclarado, 
					string sCdAvisoRecebimento, 
					System.AsyncCallback callback, 
					object asyncState) {
			return this.BeginInvoke("CalcPreco", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPreco(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrecoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
			object[] results = this.Invoke("CalcPrecoData", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrecoData(
					string nCdEmpresa, 
					string sDsSenha, 
					string nCdServico, 
					string sCepOrigem, 
					string sCepDestino, 
					string nVlPeso, 
					int nCdFormato, 
					decimal nVlComprimento, 
					decimal nVlAltura, 
					decimal nVlLargura, 
					decimal nVlDiametro, 
					string sCdMaoPropria, 
					decimal nVlValorDeclarado, 
					string sCdAvisoRecebimento, 
					string sDtCalculo, 
					System.AsyncCallback callback, 
					object asyncState) {
			return this.BeginInvoke("CalcPrecoData", new object[] {
						nCdEmpresa,
						sDsSenha,
						nCdServico,
						sCepOrigem,
						sCepDestino,
						nVlPeso,
						nCdFormato,
						nVlComprimento,
						nVlAltura,
						nVlLargura,
						nVlDiametro,
						sCdMaoPropria,
						nVlValorDeclarado,
						sCdAvisoRecebimento,
						sDtCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrecoData(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrazo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino) {
			object[] results = this.Invoke("CalcPrazo", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino, System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("CalcPrazo", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrazo(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrazoData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrazoData(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
			object[] results = this.Invoke("CalcPrazoData", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino,
						sDtCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrazoData(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo, System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("CalcPrazoData", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino,
						sDtCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrazoData(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrazoRestricao", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrazoRestricao(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
			object[] results = this.Invoke("CalcPrazoRestricao", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino,
						sDtCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrazoRestricao(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo, System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("CalcPrazoRestricao", new object[] {
						nCdServico,
						sCepOrigem,
						sCepDestino,
						sDtCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrazoRestricao(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoFAC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultado CalcPrecoFAC(string nCdServico, string nVlPeso, string strDataCalculo) {
			object[] results = this.Invoke("CalcPrecoFAC", new object[] {
						nCdServico,
						nVlPeso,
						strDataCalculo});
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcPrecoFAC(string nCdServico, string nVlPeso, string strDataCalculo, System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("CalcPrecoFAC", new object[] {
						nCdServico,
						nVlPeso,
						strDataCalculo}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultado EndCalcPrecoFAC(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultado)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcDataMaxima", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultadoObjeto CalcDataMaxima(string codigoObjeto) {
			object[] results = this.Invoke("CalcDataMaxima", new object[] {
						codigoObjeto});
			return ((cResultadoObjeto)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginCalcDataMaxima(string codigoObjeto, System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("CalcDataMaxima", new object[] {
						codigoObjeto}, callback, asyncState);
		}
		
		/// <remarks/>
		public cResultadoObjeto EndCalcDataMaxima(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultadoObjeto)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListaServicos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultadoServicos ListaServicos() {
			object[] results = this.Invoke("ListaServicos", new object[0]);
			return ((cResultadoServicos)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginListaServicos(System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("ListaServicos", new object[0], callback, asyncState);
		}
		
		/// <remarks/>
		public cResultadoServicos EndListaServicos(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultadoServicos)(results[0]));
		}
		
		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListaServicosSTAR", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public cResultadoServicos ListaServicosSTAR() {
			object[] results = this.Invoke("ListaServicosSTAR", new object[0]);
			return ((cResultadoServicos)(results[0]));
		}
		
		/// <remarks/>
		public System.IAsyncResult BeginListaServicosSTAR(System.AsyncCallback callback, object asyncState) {
			return this.BeginInvoke("ListaServicosSTAR", new object[0], callback, asyncState);
		}
		
		/// <remarks/>
		public cResultadoServicos EndListaServicosSTAR(System.IAsyncResult asyncResult) {
			object[] results = this.EndInvoke(asyncResult);
			return ((cResultadoServicos)(results[0]));
		}
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cResultado {
		
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public cServico[] Servicos;
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cServico {
		
		/// <remarks/>
		public int Codigo;
		
		/// <remarks/>
		public string Valor;
		
		/// <remarks/>
		public string PrazoEntrega;
		
		/// <remarks/>
		public string ValorMaoPropria;
		
		/// <remarks/>
		public string ValorAvisoRecebimento;
		
		/// <remarks/>
		public string ValorValorDeclarado;
		
		/// <remarks/>
		public string EntregaDomiciliar;
		
		/// <remarks/>
		public string EntregaSabado;
		
		/// <remarks/>
		public string Erro;
		
		/// <remarks/>
		public string MsgErro;
		
		/// <remarks/>
		public string ValorSemAdicionais;
		
		/// <remarks/>
		public string obsFim;
		
		/// <remarks/>
		public string DataMaxEntrega;
		
		/// <remarks/>
		public string HoraMaxEntrega;
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cServicosCalculo {
		
		/// <remarks/>
		public string codigo;
		
		/// <remarks/>
		public string descricao;
		
		/// <remarks/>
		public string calcula_preco;
		
		/// <remarks/>
		public string calcula_prazo;
		
		/// <remarks/>
		public string erro;
		
		/// <remarks/>
		public string msgErro;
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cResultadoServicos {
		
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public cServicosCalculo[] ServicosCalculo;
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cObjeto {
		
		/// <remarks/>
		public string codigo;
		
		/// <remarks/>
		public string servico;
		
		/// <remarks/>
		public string cepOrigem;
		
		/// <remarks/>
		public string cepDestino;
		
		/// <remarks/>
		public int prazoEntrega;
		
		/// <remarks/>
		public string dataPostagem;
		
		/// <remarks/>
		public string dataPostagemCalculo;
		
		/// <remarks/>
		public string dataMaxEntrega;
		
		/// <remarks/>
		public string postagemDH;
		
		/// <remarks/>
		public string dataUltimoEvento;
		
		/// <remarks/>
		public string codigoUltimoEvento;
		
		/// <remarks/>
		public string tipoUltimoEvento;
		
		/// <remarks/>
		public string descricaoUltimoEvento;
		
		/// <remarks/>
		public string erro;
		
		/// <remarks/>
		public string msgErro;
		
		/// <remarks/>
		public string nuTicket;
		
		/// <remarks/>
		public string formaPagamento;
		
		/// <remarks/>
		public string valorPagamento;
	}
	
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "5.1.0.5216-0e58df71")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
	public partial class cResultadoObjeto {
		
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public cObjeto[] Objetos;
	}
}