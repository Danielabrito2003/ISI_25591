using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace GestaoReceitasExercicios
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Verifica se o endpoint requer autenticação
            if (context.Request.Headers.TryGetValue("Authorization", out var token))
            {
                // Autenticação básica com um token fixo 
                if (token == "Bearer MeuTokenSecreto")
                {
                    await _next(context);
                    return;
                }
            }

            // Retorna 401 Unauthorized se o token não for válido ou não for fornecido
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await context.Response.WriteAsync("Autenticação falhou. Token inválido ou ausente.");
        }
    }
}
