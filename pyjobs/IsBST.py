def checkBST(node):
    if node is None:
        return True
    
    nodeIsCorrect = isLower(node.left, node.data) and isGreater(node.right, node.data)

    if (not nodeIsCorrect):
        return False
    
    return checkBST(node.left) and checkBST(node.right)
    
def isLower(node, data):
    if node is None:
        return True
    
    if node.data >= data:
        return False

    return isLower(node.left, data) and isLower(node.right, data)

def isGreater(node, data):
    if node is None:
        return True
    
    if node.data <= data:
        return False

    return isGreater(node.left, data) and isGreater(node.right, data)    