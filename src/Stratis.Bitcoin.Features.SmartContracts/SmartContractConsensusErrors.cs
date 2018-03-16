﻿using Stratis.Bitcoin.Features.Consensus;

namespace Stratis.Bitcoin.Features.SmartContracts
{
    public static class SmartContractConsensusErrors
    {
        public static readonly ConsensusError UserOpSpend = new ConsensusError("op-spend-by-user", "op spend opcode invoked by a user");
        public static readonly ConsensusError UnequalCondensingTx = new ConsensusError("invalid-condensing-tx", "condensing tx generated didn't match tx in block");
        public static readonly ConsensusError UnequalStateRoots = new ConsensusError("invalid-state-roots", "contract state root not matching after block execution");
    }
}
