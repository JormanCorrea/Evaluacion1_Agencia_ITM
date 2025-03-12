using System;
using System.Reflection;

namespace Agencia_Viviendas_ITM.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}