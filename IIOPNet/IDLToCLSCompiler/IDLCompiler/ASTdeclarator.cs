/* Generated By:JJTree: Do not edit this line. ASTdeclarator.cs */

using System;

namespace parser {

public class ASTdeclarator : SimpleNode {
  public ASTdeclarator(int id) : base(id) {
  }

  public ASTdeclarator(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
}


}
