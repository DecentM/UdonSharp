using UnityEditor;
using UnityEngine;

namespace DecentM.Udonlyn.Compiler
{
    public enum InstructionKind
    {
        Nop,
        Push,
        Pop,
        JumpIfFalse,
        Jump,
        Extern,
        Annotation,
        JumpIndirect,
        Copy,
    }

    public struct Instruction<Kind> where Kind : struct
    {
        public Kind kind;
    }
    
    public class Ast
    {
        
    }
}
