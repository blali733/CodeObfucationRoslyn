using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeObfuscation
{
    class IOOIKORULIDQXRFOUGCMBTMTETJXGBTHTHQCNONNFSKWBOHXHTOJWBKMBTDOERNJNUUQBCBGQNGGJOROL: CSharpSyntaxRewriter
    {
        public IOOIKORULIDQXRFOUGCMBTMTETJXGBTHTHQCNONNFSKWBOHXHTOJWBKMBTDOERNJNUUQBCBGQNGGJOROL() { }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var UPVXDPSAUJKBLHVUQVXFNEBVIVVBJXAFTDXTXMXUFSJHXVXOLNDUXLJQOAPGRQPVJEGIHBUE= node.Identifier.ValueText;
            var JQKWBCSTNVDDWDRJCLLEHVHBDBJOUNRFMAUMBSRWSTGGLPRTAMDDLQNLIJTARDWXDWOVHEHHRMKLPBNL= "";
            if (BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.VANRFCWHOSAVXWTICCBHPQOVLVUXQUXDNPIFQNBOASWQAMVFKHMVJWUFJQFHFWPR.ContainsKey(UPVXDPSAUJKBLHVUQVXFNEBVIVVBJXAFTDXTXMXUFSJHXVXOLNDUXLJQOAPGRQPVJEGIHBUE))
            {
                JQKWBCSTNVDDWDRJCLLEHVHBDBJOUNRFMAUMBSRWSTGGLPRTAMDDLQNLIJTARDWXDWOVHEHHRMKLPBNL = BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.VANRFCWHOSAVXWTICCBHPQOVLVUXQUXDNPIFQNBOASWQAMVFKHMVJWUFJQFHFWPR[UPVXDPSAUJKBLHVUQVXFNEBVIVVBJXAFTDXTXMXUFSJHXVXOLNDUXLJQOAPGRQPVJEGIHBUE];
            }
            else
            {
                JQKWBCSTNVDDWDRJCLLEHVHBDBJOUNRFMAUMBSRWSTGGLPRTAMDDLQNLIJTARDWXDWOVHEHHRMKLPBNL = BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.WEJHFELMWHVOGEORBPOAHJOPUDVRMNEVIREXDRQUCMHHNFIJCFVFLGEMOSLBH(BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.VANRFCWHOSAVXWTICCBHPQOVLVUXQUXDNPIFQNBOASWQAMVFKHMVJWUFJQFHFWPR.Count() + 1);
                BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.TUHINNPNAKHURWVXAPNIIBSPSDTAHSJBDEVDENQUPXUWPXMLTGGOJGJRCQOKSPFGB[UPVXDPSAUJKBLHVUQVXFNEBVIVVBJXAFTDXTXMXUFSJHXVXOLNDUXLJQOAPGRQPVJEGIHBUE] = JLMSVBBREMWJRJPOCWVUUDBMDIJOWSUWQIEMAEQDUXETQXWDOXVCAHWGJAOMPLSKPXRIECNVFSXUWFTDKFAWURVJJWDAN.En_Priority.CLASS;
                BLSVUOJMAXPVAKJUFLGRGCNPOIPECQSKJLMCXPFCDMBVBOBFOLUPNQXWVCHL.Instance.VANRFCWHOSAVXWTICCBHPQOVLVUXQUXDNPIFQNBOASWQAMVFKHMVJWUFJQFHFWPR[UPVXDPSAUJKBLHVUQVXFNEBVIVVBJXAFTDXTXMXUFSJHXVXOLNDUXLJQOAPGRQPVJEGIHBUE] = JQKWBCSTNVDDWDRJCLLEHVHBDBJOUNRFMAUMBSRWSTGGLPRTAMDDLQNLIJTARDWXDWOVHEHHRMKLPBNL;
            }

            ClassDeclarationSyntax JPLKKISUDARLWILEAIERPWERIQISDDLBMCSCCWCLCTVBITSFSCIFMUULLRCSXXRANPWUNJCCGROUBCJNWD= node.WithIdentifier(Identifier(JQKWBCSTNVDDWDRJCLLEHVHBDBJOUNRFMAUMBSRWSTGGLPRTAMDDLQNLIJTARDWXDWOVHEHHRMKLPBNL)).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia());
            return node.ReplaceNode(node, JPLKKISUDARLWILEAIERPWERIQISDDLBMCSCCWCLCTVBITSFSCIFMUULLRCSXXRANPWUNJCCGROUBCJNWD);
        }

    }
}
